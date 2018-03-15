let expect = require('chai').expect;
let should = require('chai').should;
let assert = require('chai').assert;
let lookupChar = require('../CharLookUp').lookupChar;

describe('A function that accepts a string - the string in which we’ll search'
 +'and a number - the index of the char we want to lookup', function () {
    it("should return undefined for 1,1", function () {
        expect(lookupChar(1,1)).to.be.equal(undefined)
    })
    it("should return undefined for str,str", function () {
        expect(lookupChar('str','str')).to.be.equal(undefined)
    })
    it("should return undefined for str,2.2", function () {
        expect(lookupChar('str',2.2)).to.be.equal(undefined)
    })
    it("should return `Incorrect index` for str,-1", function () {
        expect(lookupChar('str',-1)).to.be.equal("Incorrect index")
    })
    it("should return `Incorrect index` for str,6", function () {
        expect(lookupChar('str',6)).to.be.equal("Incorrect index")
    })
    it("should return t for str,1", function () {
        expect(lookupChar('str',1)).to.be.equal("t")
    })
    it("should return ` ` for `longest string you have ever seen`,14+14", function () {
        expect(lookupChar(`longest string you have ever seen`,14+14)).to.be.equal(" ")
    })
})