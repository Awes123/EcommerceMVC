/**
 * Dashboard JS - Dashboard js for APEZ template
 * @version v1.2.0
 * @copyright 2017 Pepdev.
 */

/**
* OnDOMLoad
* Tooltip
* Perfect Scrollbar
* Full Screen
* ThemeSlider
* Sidebar menu
* Switchery Js
* ThemeAccordion
*/
$(document).ready(function () {
	"use strict";

        $('.loader-wrapper').hide();
    $(window).on("load", function (e) {
        $('.loader-wrapper').hide();
    });

    //Theme Customizer
    $('body').prepend('<div class="setting-wrapper">' +
        '<div class="setting-handle"><i class="fa fa-cog spinner"></i></div>' +
        '<div class="setting-container">' +
        '<div class="setting-layout">' +
        '<h5 class="text-left font-20 font-500">Layout</h5>' +
        '<div class="layout text-left ml-2">' +
        '<div class="custom-control custom-checkbox custom-checkbox-1 mb-3">' +
        '<input type="checkbox" class="custom-control-input" name="setting_layout" id="setting-layout-wide" value="wide">' +
        '<label class="custom-control-label font-12" for="setting-layout-wide">Wide Layout</label>' +
        '</div>' +
        '<div class="custom-control custom-checkbox custom-checkbox-1 mb-3">' +
        '<input type="checkbox" class="custom-control-input" name="setting_layout" id="setting-layout-boxed" value="boxed">' +
        '<label class="custom-control-label font-12" for="setting-layout-boxed">Boxed Layout</label>' +
        '</div>' +
        '<div class="custom-control custom-checkbox custom-checkbox-1 mb-3">' +
        '<input type="checkbox" class="custom-control-input" name="setting_layout" id="setting-layout-static" value="static">' +
        '<label class="custom-control-label font-12" for="setting-layout-static">Static Layout</label>' +
        '</div>' +
        '<div class="custom-control custom-checkbox custom-checkbox-1 mb-3">' +
        '<input type="checkbox" class="custom-control-input" name="setting_layout" id="setting-layout-fixed" value="fixed">' +
        '<label class="custom-control-label font-12" for="setting-layout-fixed">Fixed Layout</label>' +
        '</div>' +
        '<div class="custom-control custom-checkbox custom-checkbox-1 mb-3">' +
        '<input type="checkbox" class="custom-control-input" name="setting_layout" id="setting-layout-collapsed" value="collapsed">' +
        '<label class="custom-control-label font-12" for="setting-layout-collapsed">Collapsed Menu</label>' +
        '</div>' +
        '</div>' +
        '</div>' +
        '<div class="setting-menu-color">' +
        '<h5 class="text-left font-20 font-500">Menu Color</h5>' +
        '<div class="layout">' +
        '<a href="#" data-color="white">Light Menu</a>' +
        '<a href="#" data-color="Dark">Dark Menu</a>' +
        '</div>' +
        '</div>' +
        '<div class="setting-color text-left">' +
        '<h5 class="text-left font-20 font-500">Header Color</h5>' +
        '<h6 class="text-left font-16 font-500">With Light sidebar</h6>' +
        '<a data-menu="white" data-color="primary" style="background-color: #3483FF"></a>' +
        '<a data-menu="white" data-color="success" style="background-color: #0bc36e"></a>' +
        '<a data-menu="white" data-color="secondary" style="background-color: #282a3c"></a>' +
        '<a data-menu="white" data-color="warning" style="background-color: #fec107"></a>' +
        '<a data-menu="white" data-color="danger" style="background-color: #fb9678"></a>' +
        '<a data-menu="white" data-color="info" style="background-color: #03a9f3"></a>' +
        '<a data-menu="white" data-color="dark" style="background-color: #555"></a>' +
        '<h6 class="text-left font-16 font-500">With Dark sidebar</h6>' +
        '<a data-menu="dark" data-color="primary" style="background-color: #3483FF"></a>' +
        '<a data-menu="dark" data-color="success" style="background-color: #0bc36e"></a>' +
        '<a data-menu="dark" data-color="secondary" style="background-color: #282a3c"></a>' +
        '<a data-menu="dark" data-color="warning" style="background-color: #fec107"></a>' +
        '<a data-menu="dark" data-color="danger" style="background-color: #fb9678"></a>' +
        '<a data-menu="dark" data-color="info" style="background-color: #03a9f3"></a>' +
        '<a data-menu="dark" data-color="dark" style="background-color: #555"></a>' +
        '<h6 class="text-left font-16 font-500">With Gradient</h6>' +
        '<a data-menu="gradient" data-color="primary" class="gradient" style="background-color: #3483FF"></a>' +
        '<a data-menu="gradient" data-color="success" class="gradient" style="background-color: #0bc36e"></a>' +
        '<a data-menu="gradient" data-color="secondary" class="gradient" style="background-color: #282a3c"></a>' +
        '<a data-menu="gradient" data-color="warning" class="gradient" style="background-color: #fec107"></a>' +
        '<a data-menu="gradient" data-color="danger" class="gradient" style="background-color: #fb9678"></a>' +
        '<a data-menu="gradient" data-color="info" class="gradient" style="background-color: #03a9f3"></a>' +
        '<a data-menu="gradient" data-color="dark" class="gradient" style="background-color: #555"></a>' +
        '</div>' +
        '</div>' +
        '</div>');
    //
    $('.setting-handle').click(function () {
        var ele = $('.setting-wrapper');
        if (ele.css('right') === '0px') {
            ele.css('right', '-255px');
        } else {
            ele.css('right', '0');
        }
    });

    $('.setting-layout a').click(function (e) {
        e.preventDefault();
        var ele = $(this);
        $('.setting-layout a').removeClass('active');
        if (ele.data('layout') === 'boxed') {
            $('.wrapper').addClass('boxed');
            ele.addClass('active');
        } else {
            $('.wrapper').removeClass('boxed');
            ele.addClass('active');
        }   
    });

    $('body').on('click', '.setting-menu-color a', function (e) {
        e.preventDefault();
        var ele = $(this);
        $('.setting-menu-color a').removeClass('active');
        if (ele.data('color') === 'white') {
            $('#main-wrapper').addClass('menu-light');
            ele.addClass('active');
        } else {
            $('#main-wrapper').removeClass('menu-light');
            ele.addClass('active');
        }   
    });

    $('body').on('click', '.setting-color a', function (e) {
        e.preventDefault();
        var ele = $(this), 
        hdr = $('.page-hdr');
        hdr.removeClass('bg-primary');
        hdr.removeClass('bg-success');
        hdr.removeClass('bg-secondary');
        hdr.removeClass('bg-warning');
        hdr.removeClass('bg-danger');
        hdr.removeClass('bg-info');
        hdr.removeClass('bg-dark');
        hdr.removeClass('page-hdr-gradient');
        if (ele.data('menu') === 'white') {
            $('#main-wrapper').addClass('menu-light');
            hdr.addClass('page-hdr-colored');
            hdr.addClass('bg-' + ele.data('color'));
        }
        if (ele.data('menu') === 'gradient') {
            $('#main-wrapper').removeClass('menu-light');
            hdr.addClass('page-hdr-colored page-hdr-gradient');
            hdr.addClass('bg-' + ele.data('color'));
        }
        if (ele.data('menu') === 'dark') {
            $('#main-wrapper').removeClass('menu-light');
            hdr.addClass('page-hdr-colored');
            hdr.addClass('bg-' + ele.data('color'));
        }
    });

    if ($('.setting-wrapper').length > 0) {
        new PerfectScrollbar('.setting-container', {
            wheelSpeed: 2,
            minScrollbarLength: 20
        });
    }
    $("input[name='setting_layout']").change(function () {
        var ele = $(this), val = ele.val();

        if (val === "boxed") {
            $("#setting-layout-wide").prop("checked", false);
            $('.wrapper').addClass('boxed');
        }
        if (val === "wide") {
            $("#setting-layout-boxed").prop("checked", false);
            $('.wrapper').removeClass('boxed');
        } 
        if (val === "static") {
            $("#setting-layout-fixed").prop("checked", false);
            $('#main-wrapper').removeClass('menu-fixed');
            $('#main-wrapper').removeClass('page-hdr-fixed');
        }
        if (val === "collapsed") {
            $('#main-wrapper').addClass('page-menu-small');
        }
        if (val === "fixed") {
            $("#setting-layout-static").prop("checked", false);
            $('#main-wrapper').addClass('menu-fixed');
            $('#main-wrapper').addClass('page-hdr-fixed');
        }

        if (ele.attr('id') === "setting-layout-boxed" && ele.prop('checked') === false) {
            $("#setting-layout-wide").prop("checked", true);
            $('.wrapper').removeClass('boxed');
        }

        if (ele.attr('id') === "setting-layout-collapsed" && ele.prop('checked') === false) {
            $('#main-wrapper').removeClass('page-menu-small');
        }

        if (ele.attr('id') === "setting-layout-static" && ele.prop('checked') === false) {
            $('#main-wrapper').addClass('menu-fixed');
            $('#main-wrapper').addClass('page-hdr-fixed');
        }
    });

	//*************************************************
    //Tooltip Tippy  **********************************
    //*************************************************	
    tippy('.tippy');

    $('[data-toggle="tooltip"]').tooltip();


    //*************************************************
    //Perfect Scrollbar  ******************************
    //************************************************* 
    if ($('.menu-fixed').length > 0 && $('.menu-wrapper').length > 0) {
        new PerfectScrollbar('.menu-fixed .menu-wrapper .menu ul', {
            wheelSpeed: 2,
            minScrollbarLength: 20
        });
    }


    //*************************************************
    //Full Screen  ************************************
    //************************************************* 
    function launchIntoFullscreen(element) {
        if (element.requestFullscreen) {
            element.requestFullscreen();
        } else if (element.mozRequestFullScreen) {
            element.mozRequestFullScreen();
        } else if (element.webkitRequestFullscreen) {
            element.webkitRequestFullscreen();
        } else if (element.msRequestFullscreen) {
            element.msRequestFullscreen();
        }
    }

    function exitFullscreen() {
        if (document.exitFullscreen) {
            document.exitFullscreen();
        } else if (document.mozCancelFullScreen) {
            document.mozCancelFullScreen();
        } else if (document.webkitExitFullscreen) {
            document.webkitExitFullscreen();
        }
    }

    $('body').on('click', '.page-fullscreen', function () {
        var ele = $(this), target_ele = ele.find('a .fa-expand');
        if (target_ele.length > 0) {
            launchIntoFullscreen(document.documentElement);
            target_ele.addClass('fa-compress');
            target_ele.removeClass('fa-expand');
        } else {
            exitFullscreen();
            ele.find('a i').addClass('fa-expand');
            ele.find('a i').removeClass('fa-compress');
        }
    });


    //*************************************************
    //Sidebar menu  ***********************************
    //*************************************************
    $('body').on('click', '.open-sidebar-right', function () {
    	var ele = $(this), body = $('body');
    	body.css('overflow', 'hidden');
    	body.append('<div class="overlay"></div>');
    	setTimeout(function() { $('.sidebar-right').css('right', '0'); }, 50);
    });

    $('body').on('click', '.sidebar-close, .overlay', function () {
    	$('body').css('overflow', 'visible');
    	$('.sidebar-right').css('right', '-450px');
    	setTimeout(function() { $('.overlay').remove(); }, 200);
    });

	//*************************************************
    //Left Side menu  *********************************
    //*************************************************
    $('body').on('click', '.menu-close', function () {
    	var ele = $(this);
    	$('#main-wrapper').addClass('page-menu-small');
    	ele.find('i').removeClass('fa-hand-point-left');
    	ele.find('i').addClass('fa-hand-point-right');
    	ele.removeClass('menu-close');
    	ele.addClass('menu-open');
    });

    $('body').on('click', '.menu-open', function () {
    	var ele = $(this);
    	$('#main-wrapper').removeClass('page-menu-small');
    	ele.find('i').removeClass('fa-hand-point-right');
    	ele.find('i').addClass('fa-hand-point-left');
    	ele.removeClass('menu-open');
    	ele.addClass('menu-close');
    });

	//Left side Sub Menu
    $('body').on('click', 'li.has-sub > a', function () {
        var ele = $(this), target = ele.parent('li.has-sub').find('ul.sub-menu:first');
        ele.parent('li.has-sub').siblings('li').find('a .arrow').removeClass('rotate');
        if (target.css('display') === "none") {
            ele.parent('li.has-sub').siblings('li').find('.sub-menu').slideUp();
            ele.find('.arrow').addClass('rotate');
            target.slideDown();
        } else {
            ele.parent('li.has-sub').find('.arrow').removeClass('rotate');
            ele.parent('li.has-sub').find('ul.sub-menu').slideUp();
        }
        return false;
    });


    $('body').on('click', 'li.navbar-dropdown-wrapper > a', function () {
        var ele = $(this), target = ele.parent('li.navbar-dropdown-wrapper').find('.navbar-dropdown:first, .navbar-megamenu');
        if (target.css('display') === "none") {
            ele.parent('li.navbar-dropdown-wrapper').siblings('li').find('.navbar-dropdown, .navbar-megamenu').slideUp();
            target.slideDown();
        } else {
            ele.parent('li.navbar-dropdown-wrapper').find('.navbar-dropdown, .navbar-megamenu').slideUp();
        }
        return false;
    });


    //Open Page hdr right menu in Mobile
    $('body').on('click', '.oepn-page-menu-desktop', function () {
        var ele = $('.page-hdr-desktop');
        $('.page-search').slideUp(300);
        if (ele.css('display') === "none") {
            ele.slideDown(300);
        } else {
            ele.slideUp(300);
        }
    });
    //Open Page search in mobile
    $('body').on('click', '.open-mobile-search', function () {
        var ele = $('.page-search');
        $('.page-hdr-desktop').slideUp(300);
        if (ele.css('display') === "none") {
            ele.slideDown(300);
        } else {
            ele.slideUp(300);
        }
    });

    //Open Left Side Menu in mobile
    $('body').on('click', '.open-left-menu', function () {
        var ele = $('.menu-wrapper'), nav_ele = $('.navbar-container');
        $('body').append('<div class="menu-overlay"></div>');
        ele.addClass('menu-mobile-open');
        nav_ele.addClass('menu-mobile-open');
    });
    //Close Left Side Menu in mobile
    $('body').on('click', '.menu-overlay', function () {
        $('.menu-wrapper, .navbar-container').removeClass('menu-mobile-open');
        $('.menu-overlay').remove();
    });


	//*************************************************
    //Switchery Js Init  ******************************
    //*************************************************
    var elems = Array.prototype.slice.call(document.querySelectorAll('.js-switch'));
    $('.js-switch').each(function() {
    	new Switchery($(this)[0], $(this).data());
    });

    
    //*************************************************
    //ThemeAccordion **********************************
    //*************************************************
    $('.theme-accordion:nth-child(1) .theme-accordion-bdy').slideDown();
    $('.theme-accordion:nth-child(1) .theme-accordion-control .fa').addClass('fa-minus');
    $('body').on('click', '.theme-accordion-hdr', function () {
        var ele = $(this);
        $('.theme-accordion-bdy').slideUp();
        $('.theme-accordion-control .fa').removeClass('fa-minus');
        if (ele.parents('.theme-accordion').find('.theme-accordion-bdy').css('display') === "none") {
            ele.find('.theme-accordion-control .fa').addClass('fa-minus');
            ele.parents('.theme-accordion').find('.theme-accordion-bdy').slideDown();
        } else {
            ele.find('.theme-accordion-control .fa').removeClass('fa-minus');
            ele.parents('.theme-accordion').find('.theme-accordion-bdy').slideUp();
        }
    });
});
