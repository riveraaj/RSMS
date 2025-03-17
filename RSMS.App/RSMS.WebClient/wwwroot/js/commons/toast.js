window.addEventListener('load', () => {
    //Obtain the values of the data attributes of the div
    const toastData = document.getElementById('toast-data'),
        operationStatus = toastData ? toastData.getAttribute('data-status') : null,
        operationMessage = toastData ? toastData.getAttribute('data-message') : null;

    //Check if there are values to display the alert
    if (operationStatus && operationMessage) {
        showToast(operationStatus, operationMessage);
    }
});

function showToast(status, message) {
    let iconType = '',
        backgroundColor = '',
        textColor = '';

    //Determine the type of alert
    switch (status) {
        case 'Success':
            iconType = 'success';
            backgroundColor = '#eef7ea'; //green
            textColor = '#4aa02d';
            break;
        case 'Warning':
            iconType = 'warning';
            backgroundColor = '#fef9e6'; //yellow
            textColor = '#f0aa45';
            break;
        case 'Error':
            iconType = 'error';
            backgroundColor = '#fce8e4'; //red
            textColor = '#e12a02';
            break;
        default:
            iconType = 'info';
            backgroundColor = '#f2f7ff'; //blue
            textColor = '#2049fd';
            break;
    }

    //Show toast with close button
    Swal.fire({
        toast: true, //Activate toast mode
        position: 'top-end', // Position at upper right
        icon: iconType, // Type of icon (success, error, warning, etc.)
        title: message, //The message to be displayed
        showConfirmButton: false, //Do not show the confirmation button
        timer: 5000, //Duration in milliseconds (7 seconds)
        background: backgroundColor, //Personalized background
        color: textColor,
        timerProgressBar: true, //Show progress bar while toast is active
        showCloseButton: true, //Show close button
        closeButtonAriaLabel: 'Cerrar', //Alternative text for accessibility
    });
}