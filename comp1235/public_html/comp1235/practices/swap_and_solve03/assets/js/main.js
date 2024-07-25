document.getElementById('registrationForm').addEventListener('submit', function(event) {
    event.preventDefault();

    const name = document.getElementById('nameInput').value;
    if (!name.match(/^[a-zA-Z\s]+$/)) {
        alert("Please enter a valid name. Only letters are allowed.");
        return;
    }

    const email = document.getElementById('emailInput').value;
    if (!email.match(/^[^@]+@gmail\.com$/)) {
        alert("Please enter a valid Gmail address.");
        return;
    }

    fetch('https://dog.ceo/api/breeds/image/random')
        .then(response => response.json())
        .then(data => {
            document.getElementById('welcomeMessage').innerHTML = `<h2>Welcome, ${name}!</h2>`;
            document.getElementById('dogImage').src = data.message;
            document.getElementById('dogImage').style.display = 'block';
        })
        .catch(error => console.error('Error fetching dog image:', error));
});
