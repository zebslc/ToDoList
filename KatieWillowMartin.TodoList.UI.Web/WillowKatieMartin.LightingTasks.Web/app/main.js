require.config({

    paths: {
        'domReady': '../Scripts/domReady',
        'angular': '../Scripts/angular',
        'app': '../app/app.module',
        'uiRouter': '../Scripts/angular-ui-router'
    },

    shim: {
        'angular': {
            'exports': 'angular'
        },
       
       
        'uiRouter': {
            'deps': ['angular'],
            'exports': 'uiRouter'
        }
    },

    deps: [
        './bootstrap'
    ]
});