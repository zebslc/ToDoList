require.config({

    paths: {
        'domReady': '../Scripts/domReady',
        'angular': '../Scripts/angular',
        'app': '../app/app.module',
        'uiRouter': '../Scripts/angular-ui-router',
        'ngResource':'../Scripts/angular-resource'
    },

    shim: {
        'angular': {
            'exports': 'angular'
        },
       
       
        'uiRouter': {
            'deps': ['angular'],
            'exports': 'uiRouter'
        },

        'ngResource':{
            'deps':['angular'],
            'exports':'ngResource'
        }
    },

    deps: [
        './bootstrap'
    ]
});