'use strict';

var angular = require('angular');

angular
    .module('app')
    .controller('showProductTypes', showProductTypes);

showProductTypes.$inject = ['productTypeService'];

function showProductTypes(productTypeService) {
    //bind не срабатывает
    var self = this;

    this.products = [];    

    activate();

    function activate() {
        return productTypeService.getAll()
            .then(function (data) {
                self.products = data;
            });
    }

}
