var app = angular.module("feedbackApp", ["ui.bootstrap"]);

app.controller("feedbackFormController", function ($scope, $http) {
    $scope.formData = {};
    
    // http post here

    $scope.clicked = function () {
        alert("clicked");
    }

    $scope.oneAtATime = true;
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
            debugger;
        }
    });


});