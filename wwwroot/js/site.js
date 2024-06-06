// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

function toggleVisibility(button) {
    var textSpan = button.previousElementSibling;
    if (textSpan.classList.contains('truncate-text')) {
        textSpan.classList.remove('truncate-text');
        button.textContent = 'Esconder';
    } else {
        textSpan.classList.add('truncate-text');
        button.textContent = 'Mostrar';
    }
}