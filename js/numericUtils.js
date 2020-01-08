'use strict';

let numericUtils = (function () {
    
    // return a list of even numbers from an array of number
    function evenNumerics(numbers) {
        if(!numbers || !numbers.length)
            return null;

        let evenNumbers = [];

        for(let i = 0; i < numbers.length; i++) {
            if(numbers[i] && numbers[i] % 2 === 0)
                evenNumbers.push(numbers[i]);
        }

        return evenNumbers;
    }

    // return the largest number in an array
    function largestNumber(numbers) {
        if(!numbers || !numbers.length)
            return null;

        let largestNumber = numbers[0];

        for(let i = 0; i < numbers.length; i++) {
            if(numbers[i] && numbers[i] > largestNumber)
                largestNumber = numbers[i];
        }

        return largestNumber;
    }

    return {

        evenNumerics: evenNumerics,
        largestNumber: largestNumber,

    }
})();
