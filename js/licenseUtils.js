'use strict';



let licenseUtils = (function () {

    // Consider this list of formats: https://ntsi.com/drivers-license-format/
    // Validate Driver's license number, implement Nebraska and Mississippi in an expandable way to eventually handle all US states.
    // Fail validation if unexpected data is passed in.
    // Nebraska: 1Alpha+6-8Numeric
    // Mississippi: 9Numeric

    var stateValidations = {
        'MS': /^\d{9}$/,
        "NE": /^[A-Za-z]\d{6,8}$/
    };

    function validate(license, state) {

        const validationRegex = stateValidations[state];

        if (!validationRegex)
            return false;

        return !!validationRegex.exec(license);
    }
    return {

        validate: validate

    }
})();
