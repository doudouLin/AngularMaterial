
'use strict';

var controllerId = 'boardController';

angular.module('BoardApp').controller(controllerId,
    ['$scope', 'boardFactory', '$mdDialog', boardController]);

function boardController($scope, boardFactory, $mdDialog) {
    $scope.data = [];

    boardFactory.getData().success(function (data) {
        $scope.data = data;
    }).error(function (error) {
        // log errors
    });

    $scope.showAdvanced = function (ev, name) {
        $scope.currentPat = name;
        $mdDialog.show({
            controller: DialogController,
            templateUrl: 'app/partials/dialog1.tmpl.html',
            parent: angular.element(document.body),
            scope: $scope.$new(),
            targetEvent: ev,
            clickOutsideToClose: true,
            fullscreen: $scope.customFullscreen // Only for -xs, -sm breakpoints.
        })
        .then(function (answer) {
            $scope.status = 'You said the information was "' + answer + '".';
        }, function () {
            $scope.status = 'You cancelled the dialog.';
        });
    };

    function DialogController($scope, $mdDialog) {
        $scope.hide = function() {
            $mdDialog.hide();
        };

        $scope.cancel = function() {
            $mdDialog.cancel();
        };

        $scope.answer = function(answer) {
            $mdDialog.hide(answer);
        };
    }

    //Timerjob, refresh data every 10 seconds
    setInterval(function () {
        boardFactory.getData().success(function (data) {
            $scope.data = data;
        }).error(function (error) {
            // log errors
        });
    }, 10000);
}