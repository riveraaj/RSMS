/* Hanlder update fields */
document.addEventListener('DOMContentLoaded', function () {
    const forms = document.querySelectorAll('.update-property-form');

    forms.forEach(form => {
        form.addEventListener('change', function (e) {
            const url = form.getAttribute('data-url'),
                formData = new FormData(form);

            let emptyInputs = false;

            formData.forEach((value, key) => {
                if (key === "property.PropertyTypeId") {
                    formData.append("PropertyUpdateObj.PropertyTypeId", value);
                    formData.delete(key);
                }
                if (key === "property.OwnerId") {
                    formData.append("PropertyUpdateObj.OwnerId", value);
                    formData.delete(key);
                }
            });

            const data = new URLSearchParams(formData);

            fetch(url, {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/x-www-form-urlencoded',
                },
                body: data.toString()
            })
                .then(response => {
                    if (!response.ok) throw new Error(`HTTP error! status: ${response.status}`);
                    return response.json();
                })
                .then(data => showToast(data.status, data.message))
                .catch(() => showToast("Error", "The field could not be updated."));
        });
    });
});