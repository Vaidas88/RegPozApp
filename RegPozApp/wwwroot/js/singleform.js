let formSelects = document.querySelectorAll('table tbody tr select');
let initialValues = [];

let editButton = document.getElementById('edit');
let cancelButton = document.getElementById('cancel');

window.onload = function () {
    let selectElements = document.querySelectorAll('select');
    selectElements.forEach(element => element.disabled = true);

    formSelects.forEach(element => {
        initialValues.push(element.value);
    });
}

editButton.onclick = function () {
    let disbaledElements = document.querySelectorAll('select:disabled, input:disabled');
    disbaledElements.forEach(element => element.disabled = false);
}

cancelButton.onclick = function () {
    for (let i = 0; i < formSelects.length; i++) {
        formSelects[i].value = initialValues[i];
    }
}