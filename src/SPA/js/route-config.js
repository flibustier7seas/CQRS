'use strict';

var angular = require('angular');

angular
   .module('app')
   .config(config);

function config($routeProvider) {
    $routeProvider
        .when('/createProductType',
        {
            templateUrl: 'js/createProductType/createProductType.html',
            controller: 'createProductType',
            controllerAs: 'ctrl'
        })
        .when('/showProductTypes',
        {
            templateUrl: 'js/showProductTypes/showProductTypes.html',
            controller: 'showProductTypes',
            controllerAs: 'ctrl'
        })
        .otherwise({ redirectTo: '/showProductTypes' });;
}