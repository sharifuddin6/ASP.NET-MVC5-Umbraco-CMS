var app = angular.module("app", []);
app = angular.module("app", ["ui.bootstrap"]);

app.controller("AccordionController", function ($scope) {
    $scope.clicked = function () {
        alert("clicked");
    }

    $scope.oneAtATime = true;

});