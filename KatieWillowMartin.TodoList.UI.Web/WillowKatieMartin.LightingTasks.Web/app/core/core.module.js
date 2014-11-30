define(
    'app.core',
    [
        'angular',
        'uiRouter'
    ]
    ,
    function (angular) {
        return angular.module('app.core', ['ui.router']);
    });
