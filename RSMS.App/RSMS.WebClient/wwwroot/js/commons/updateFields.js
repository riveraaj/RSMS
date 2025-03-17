/* Hanlder update fields */
document.addEventListener('DOMContentLoaded', function () {
    const forms = document.querySelectorAll('.update-form');

    forms.forEach(form => {
        form.addEventListener('change', function (e) {
            const url = form.getAttribute('data-url'),
                formData = new FormData(form),
                data = new URLSearchParams(formData);

            let emptyInputs = false;

            formData.forEach((value, key) => emptyInputs = (value === "" || value === null) ?  true : false);

            if (!emptyInputs) {
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
            } else if (emptyInputs) {
                showToast("Warning", "Empty fields cannot be left.");
            }
        });
    });
});