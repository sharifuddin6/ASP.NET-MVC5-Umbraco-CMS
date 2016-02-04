var app = angular.module("contactApp", []);

app.controller("contactController", function ($scope) {
    $scope.submit = function () {
        $scope.messageSent = true;
    }

    $scope.reset = function () {
        $scope.messageSent = false;
    }

    $scope.messageSent = false;
});