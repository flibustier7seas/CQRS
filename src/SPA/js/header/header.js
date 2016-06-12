
'use strict';

var angular = require('angular');

angular
    .module('app')
    .controller('header', header);

header.$inject = ['$location'];

function header($location) {
    this.isActive = function (viewLocation) {
        return viewLocation === $location.path();
    };
}
