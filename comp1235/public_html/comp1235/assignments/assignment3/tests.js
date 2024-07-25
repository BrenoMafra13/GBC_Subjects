"use strict";

const chai = window.chai;
const expect = chai.expect;

describe('Circle(radius)', () =>  {
    it('this Circle constructor with area and perimeter',  () => {
        expect(new Circle(3).area()).to.deep.equal(28.27);
        expect(new Circle(3).perimeter()).to.deep.equal(18.85);
        expect(new Circle(9).area()).to.deep.equal(254.47);
        expect(new Circle(9).perimeter()).to.deep.equal(56.55);
    })
})

describe('calculateSalary(array)', () =>  {
    it('this function calculate and returns calculated total gross salary',  () => {
        expect(calculateSalary([8,8,8,8,8,0,0])).to.deep.equal(400);
        expect(calculateSalary([10,10,10,0,8,0,0])).to.deep.equal(410);
        expect(calculateSalary([0,0,0,0,0,12,0])).to.deep.equal(280);
    })
})

describe('indexMultiplier(array)', () =>  {
    it('this function calculates the sum of all items in the array, each multiplied by its index',  () => {
        expect(indexMultiplier([1,2,3,4,5])).to.deep.equal(40);
        expect(indexMultiplier([-3,0,8,-6])).to.deep.equal(-2);
        expect(indexMultiplier([15,16,-100,50])).to.deep.equal(-34);
    })
})

describe('filteredJSON(array)', () =>  {
    it('return filters an array of JSON elements (id greater than 10, username within [M-N])',  () => {
        expect(filteredJSON([{id: 1, u: "batman"}, {id: 11, u: "spidey"}])).to.deep.equal([{id: 11, u: "spidey"}]);
        expect(filteredJSON([{id:1, u:"batman"}])).to.deep.equal([]);
        expect(filteredJSON([{id: 11, u: "batman"}])).to.deep.equal([]);
        expect(filteredJSON([{id: 11, u: "spidey"}])).to.deep.equal([{id: 11, u: "spidey"}]);
    })
})

describe('breakAway', () =>  {
    it('This function divides an array (first argument) into chuck of size n (second parameter)',  () => {
        expect(breakAway([2, 3], 2)).to.deep.equal([ [2, 3]])
        expect(breakAway([2,3,4,5], 2)).to.deep.equal([ [2,3], [4,5] ])
        expect(breakAway([2,3,4,5,6], 2)).to.deep.equal([ [2,3], [4,5], [6] ])
        expect(breakAway([2,3,4,5,6,7], 3)).to.deep.equal([ [2,3,4], [5,6,7] ])
        expect(breakAway([2,3,4,5], 1)).to.deep.equal([ [2],[3],[4],[5] ])
        expect(breakAway([2,3,4,5,6,7], 7)).to.deep.equal([ [2,3,4,5,6,7] ])
    })
})