let userName = prompt("Please enter your username:");
document.getElementById("welcome").innerHTML += " " + userName + "!";

function filterBooks(filter) {
    const recommendations = document.querySelectorAll('.recommendation');
    recommendations.forEach(book => {
        if (filter === 'all' || book.dataset.genre === filter || book.dataset.author === filter) {
            book.style.display = 'flex';
        } else {
            book.style.display = 'none';
        }
    });
}
