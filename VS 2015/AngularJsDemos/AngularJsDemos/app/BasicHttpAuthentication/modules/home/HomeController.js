'use strict';

angular.module('Home')

.controller('HomeController',
    ['$scope', '$location', 'AuthenticationService',
    function ($scope, $location, AuthenticationService) {

        $scope.logout = function () {
            AuthenticationService.ClearCredentials();
            $location.path('/login');
        }

    }
    ]);