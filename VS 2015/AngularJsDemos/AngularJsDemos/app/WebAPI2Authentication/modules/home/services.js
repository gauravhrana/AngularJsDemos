'use strict';

angular.module('Home')

.factory('HomeService',
    ['$http',
    function ($http) {
        var service = {};

        service.GetSecureData = function (callback) {
            $http.get('/api/securedata')
                .then(function (response) {
                    callback(response);
                });
        };

        return service;
    }]);