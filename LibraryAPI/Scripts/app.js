﻿console.log("Hello World! Javascript is running!");
angular
    .module("helloWorldApp", [])
    .controller("mainController", ["$scope", "$http", ($scope, $http) => {
        $scope.currentTime = new Date();
        $http({
            method: "GET",
            url: "/api/book"
        }).then(resp => {
            console.log(resp.data);
            $scope.books = resp.data;
        });
    }]);