(function () {
    'use strict';

    var studentService = angular.module('studentService', ['ngResource']);
    studentService.factory('student', ['$resource',
        function ($resource) {
            alert("hi");
            return $resource('/api/StudentMasters/', {}, {

                APIData: { method: 'GET', params: {}, isArray: true }

            });
            alert("hi12");
        }
    ]);
})();