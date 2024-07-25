//fetchButton
document.addEventListener('click', function(){
    
    // fetch the dog random image
    fetch("https://dog.ceo/api/breeds/image/random")
        .then (response => response.json())
        .then (data => {
            document.getElementById("randomImage").src = data.message;
        })
        .catch(error =>{
            console.error("ERROR IN FETCHING IMAGE", error);
        });

});
