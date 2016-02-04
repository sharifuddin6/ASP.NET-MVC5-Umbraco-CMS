var app = angular.module("feedbackApp", ["ui.bootstrap"]);

app.controller("feedbackFormController", function ($scope, $http) {
    $scope.messageSent = false;
    $scope.formData = {};

    $scope.processForm = function () {
        $scope.formData.datetime = new Date();
        $http({
            method: "POST",
            url: "/api/feedback",
            dataType: "json",
            data: JSON.stringify($scope.formData),
            headers: { "Content-Type": "application/json" }
        })
        .success(function (data) {
            if (!data.success) {
                // if not successful, bind errors to error variables
            } else {
                // if successful, bind success message to message
                $scope.messageSent = true;
            }
        });
    }

    $scope.reset = function () {
        $scope.messageSent = false;
    }
});

app.controller("feedbackListController", function($scope, $http) {
    $scope.messageData = {};

    $http({
        method: "GET",
        url: "/api/feedback"
    }).success(function (data) {
        if (data.length < 1) {
            // if not successful, bind errors to error variables
        } else {
            // if successful, bind success message to message
            $scope.messageData = data;
        }
    });


});