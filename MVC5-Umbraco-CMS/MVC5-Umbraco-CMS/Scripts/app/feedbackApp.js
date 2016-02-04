var app = angular.module("feedbackApp", ["ui.bootstrap"]);

app.controller("feedbackController", function ($scope) {
    $scope.clicked = function () {
        alert("clicked");
    }

    $scope.oneAtATime = true;

});