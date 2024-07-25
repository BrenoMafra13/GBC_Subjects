"use strict";

// Function 1: Random Number
function getRandomNumber() {
    return new Promise((resolve) => {
        setTimeout(() => {
            const randomNumber = Math.floor(Math.random() * 5) + 1;
            resolve(randomNumber);
        }, 500); // 0.5 seconds
    });
}

// Function 2: Get City Data
async function getCityData(city) {
    try {
        const response = await fetch(`https://geocode.xyz/${city}?json=1`);
        if (!response.ok) {
            throw new Error(`HTTP error: ${response.status}`);
        }
        const data = await response.json();
        return { longt: data.longt };
    } catch (error) {
        throw new Error(`Could not get city data: ${error.message}`);
    }
}

// Function 3: Fetch Product
async function fetchProducts(id) {
    try {
        const response = await fetch(`https://dummyjson.com/products/${id}`);
        if (!response.ok) {
            if (response.status === 404) {
                return "Could not get products: Error: HTTP error: 404";
            }
            throw new Error(`HTTP error: ${response.status}`);
        }
        const data = await response.json();
        return data.title;
    } catch (error) {
        throw new Error(`Could not fetch products: ${error.message}`);
    }
}

// Function 4: Search Store Price
async function searchStorePrice(productName) {
    try {
        const response = await fetch('https://mdn.github.io/learning-area/javascript/apis/fetching-data/can-store/products.json');
        if (!response.ok) {
            throw new Error(`HTTP error: ${response.status}`);
        }
        const products = await response.json();
        const product = products.find(product => product.name.toLowerCase() === productName.toLowerCase());
        if (!product) {
            throw new Error(`Product not found: ${productName}`);
        }
        return Number(product.price);
    } catch (error) {
        throw error;
    }
}

// Function 5: Star Wars API
async function getStarWarsCharacters() {
    try {
        const response = await fetch('https://swapi.dev/api/people/');
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }
        const data = await response.json();
        const characterMap = {};
        data.results.forEach(character => {
            characterMap[character.name] = character.url;
        });
        return { characters: characterMap };
    } catch (error) {
        console.error(`Could not get Star Wars characters: ${error}`);
        throw error;
    }
}