'use strict';

var angular = require('angular');

angular
    .module('app')
    .factory('productTypeService', productTypeService);

productTypeService.$inject = ['$http'];

function productTypeService($http) {

    var url = 'http://localhost:5000/api/productType';
    var service = {
        create: create,
        getAll: getAll
    };

    return service;

    function create(name, attributes) {
        return $http.post(url, {
            name: name,
            attributes: attributes
        }).then(function(result) {
            console.log(result);
        },
        function (result) {
            console.log(result);
        });
    }

    function getAll(name, attributes) {
        return $http.get(url)
            .then(function (result) {
                return result.data;
            },
            function (result) {
                console.log(result);
        });
    }
}