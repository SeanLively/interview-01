'use strict';

let stringUtils = (function () {
    
    // implement function that will reverse a string
    function reverse1(str) {
        if (typeof str !== 'string')
            return null;

        return str.split('').reverse().join('');
    }

    //implement another function to reverse a string
    function reverse2(str) {
        if (typeof str !== 'string')
            return null;

        var result = '';
        for (let i = str.length - 1; i >= 0; i--) {
            result += str[i];
        }

        return result;
    }

    // implement a function to truncate a string
    function safeTruncate(str, length) {
        if (typeof str !== 'string' || !length)
            return null;

        if(length < 0)
            length = 0;

        if (str.length <= length) {
            return str;
        }

        return str.slice(0, length);
    }

    return {

        reverse1: reverse1,
        reverse2: reverse2,
        safeTruncate: safeTruncate,

    }
})();
