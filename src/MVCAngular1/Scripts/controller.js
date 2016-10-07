(function () {
    'use strict';

    angular
        .module('studentapp')
        .controller('studentController', studentController);

    studentController.$inject = ['$scope', 'student'];

    function studentController($scope, student) {
     
        $scope.student = student.APIData();
    }
})();
