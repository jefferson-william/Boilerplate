'use strict';

require.config({
    baseUrl: '/Scripts',
    paths: {
		// Arquivos gerais e/ou de configurações
		'Main': 'Main',

    	// AngularJS e Material
		'Angular': '../Content/Components/angular/angular',
		'AngularAnimate': '../Content/Components/angular-animate/angular-animate',
		'AngularAria': '../Content/Components/angular-aria/angular-aria',
		'AngularMaterial': '../Content/Components/angular-material/angular-material',
		'AngularMessages': '../Content/Components/angular-messages/angular-messages',

		// Plugins do RequireJS que permite carregar diversos tipos de arquivos
        'async': '../Content/Components/require-plugins/src/async',
        'font': '../Content/Components/require-plugins/src/font',
        'image': '../Content/Components/require-plugins/src/image',
        'json': '../Content/Components/require-plugins/src/json'
    },
    shim: {
        'AngularAnimate': {
            deps: ['Angular']
        },
        'AngularAria': {
            deps: ['Angular']
        },
        'AngularMessages': {
            deps: ['Angular']
        },
        'AngularMaterial': {
            deps: ['Angular']
        },
        'Main': {
            deps: ['Angular', 'AngularAnimate', 'AngularAria', 'AngularMessages', 'AngularMaterial']
        }
    }
});

require([
    'Angular',
    'AngularAnimate',
    'AngularAria',
    'AngularMessages',
    'AngularMaterial',
    'Main'
], function (Angular, AngularAnimate, AngularAria, AngularMessages, AngularMaterial, Main) {
    console.log('Hello!');
});