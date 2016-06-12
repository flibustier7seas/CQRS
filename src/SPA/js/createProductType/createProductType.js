'use strict';

var angular = require('angular');

angular
    .module('app')
    .controller('createProductType', createProductType);

createProductType.$inject = ['$location', 'productTypeService'];

function createProductType($location, productTypeService) {
    this.productTypeName = "";
    this.attributes = [];
    this.types = [
        { value: 0, label: "string" },
        { value: 1, label: "int" },
        { value: 2, label: "double" }
    ];

    this.addAttribute = function (attributeName, attributeType) {
        this.attributes.push({
            name: attributeName,
            type: attributeType
        });
    }

    this.createProductType = function() {
        productTypeService
            .create(this.productTypeName, this.attributes)
            .then(function () {
                $location.path('/showProductTypes');
            });
    }
}
