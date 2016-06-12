'use strict';

var angular = require('angular');

require('angular-route')
angular
   .module('app', [
       'ngRoute'
   ]);

require('angular');

require('./commonServices/productTypeService');
require('./createProductType/createProductType');
require('./showProductTypes/showProductTypes');
require('./header/header');


require('./route-config');

angular.bootstrap(document, ['app']);