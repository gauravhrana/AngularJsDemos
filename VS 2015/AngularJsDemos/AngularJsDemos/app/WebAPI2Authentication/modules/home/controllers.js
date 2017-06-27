'use strict';

angular.module('Home')

.controller('HomeController',
    ['$scope', 'HomeService', '$location', 'AuthenticationService',
    function ($scope, HomeService, $location, AuthenticationService) {

        HomeService.GetSecureData(function (response) {
            $scope.secureData = response.secureData;
        });

        $scope.logout = function () {
            AuthenticationService.ClearCredentials();
            $location.path('/login');
        }
    }]);