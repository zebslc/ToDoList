define(
    [
        'require',
        'angular',
        'ngResource',
        'app'
    ],
    function (require, angular) {
        'use strict';
        require(['domReady!'], function (document) {
            angular.bootstrap(document, ['app']);
        });
    });