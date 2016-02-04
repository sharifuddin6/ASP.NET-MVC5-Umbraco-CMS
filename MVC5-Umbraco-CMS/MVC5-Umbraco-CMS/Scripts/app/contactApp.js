var app = angular.module("contactApp", []);

app.controller("contactFormController", function ($scope, $http) {
    $scope.messageSent = false;
    $scope.formData = {};

    $scope.processForm = function () {
        $scope.formData.datetime = new Date();
        $http({
            method: "POST",
            url: "/api/contact",
            dataType: "json",
            data: JSON.stringify($scope.formData),
            headers: { "Content-Type": "application/json" }
        })
        .success(function (data) {
            if (!data.success) {
                // if not successful, bind errors to error variables
                //$scope.errorName = data.errors.name;
                //$scope.errorSuperhero = data.errors.superheroAlias;
            } else {
                // if successful, bind success message to message
                //$scope.message = data.message;
                $scope.messageSent = true;
            }
        });
    }

    $scope.reset = function () {
        $scope.messageSent = false;
    }

});