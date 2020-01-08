'use strict';

let lunchUtils = (function () {

    // return the correct day of the week for the int that is passed in
    function getDow(intDow) {
        const days = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'];

        // find the day that matches
        for (let i = 0; i < days.length; i++) {
            if (intDow == i)
                return days[i];
        }

        return 'Unknown';
    }

    // return the correct lunch for the day of the week that is passed in
    function getLunch(dow) {
        const lunchMenus = ['pizza', 'burrito', 'taco', 'fish', 'haggis', 'burgers', 'tofurkey'];

        // set the lunch for each day passed in
        for (let i = 0; i < dow.length; i++) {

            dow[i].getLunch = function () {
                return lunchMenus[i];
            }
        }
    }

    return {
        getDow: getDow,
        getLunch: getLunch

    }
})();
