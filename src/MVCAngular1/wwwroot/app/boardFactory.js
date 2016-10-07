'use strict';

var serviceId = 'boardFactory';

angular.module('BoardApp').factory(serviceId,
    ['$http', boardFactory]);

function boardFactory($http) {

    function getData() {
        return $http.get('/api/data');
    }

    var service = {
        getData: getData
    };

    return service;
}