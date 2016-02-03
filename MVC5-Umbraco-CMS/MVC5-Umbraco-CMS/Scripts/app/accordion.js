var app = angular.module("app", []);

app.controller("AccordionController", function ($scope) {
    $scope.clicked = function () {
        alert("clicked");
    }
});