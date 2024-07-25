//TOPIC 1: PROMISE {Object 2 params: reject and resolve}
//PROMISE Example

import {var1} from "./walkthrough11c.js";
const myPromise = new Promise((resolve, reject) => {
    const boolean1 = false;
    if(boolean1){
        resolve("We resolve it!");
    }else{
        reject("We rejected it ");
    }    
});
myPromise.then(()=> {console.log("Sucess")})
         .catch(err=> {console.log("Oh no!", err)});

// Usage or Calling
console.log("Promise", myPromise);

//async function
async function promise1() {
    return "Promise Me!";
}
const p1 = promise1();

//call
console.log("Async Promise", p1());

