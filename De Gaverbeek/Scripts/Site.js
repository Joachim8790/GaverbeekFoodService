
function pageNavigation() {
    var snelheid = 1000;
    $("#liHome").on("click", function () {


        $('html, body').animate({
            scrollTop: $("#pageHome").position().top
        }, snelheid);

    });
    $("#liNieuwsEnPromoties").on("click", function () {

        $('html, body').animate({
            scrollTop: $("#pageNieuwsEnPromoties").position().top
        }, snelheid);

    });
    $("#liProducten").on("click", function () {

        $('html, body').animate({
            scrollTop: $("#pageProducten").position().top
        }, snelheid);

    });
    $("#liContact").on("click", function () {

        $('html, body').animate({
            scrollTop: $("#pageContact").position().top
        }, snelheid);
    });

}
function initSlider() {
    var Page = (function () {

        var $navArrows = $('#nav-arrows'),
            $nav = $('#nav-dots > span'),
            slitslider = $('#slider').slitslider({
                onBeforeChange: function (slide, pos) {

                    $nav.removeClass('nav-dot-current');
                    $nav.eq(pos).addClass('nav-dot-current');

                }
            }),

            init = function () {

                initEvents();

            },
            initEvents = function () {

                // add navigation events
                $navArrows.children(':last').on('click', function () {

                    slitslider.next();
                    return false;

                });

                $navArrows.children(':first').on('click', function () {

                    slitslider.previous();
                    return false;

                });

                $nav.each(function (i) {

                    $(this).on('click', function (event) {

                        var $dot = $(this);

                        if (!slitslider.isActive()) {

                            $nav.removeClass('nav-dot-current');
                            $dot.addClass('nav-dot-current');

                        }

                        slitslider.jump(i + 1);
                        return false;

                    });

                });

            };

        return { init: init };

    })();

    Page.init();

    /**
     * Notes: 
     * 
     * example how to add items:
     */

    /*
    
    var $items  = $('<div class="sl-slide sl-slide-color-2" data-orientation="horizontal" data-slice1-rotation="-5" data-slice2-rotation="10" data-slice1-scale="2" data-slice2-scale="1"><div class="sl-slide-inner bg-1"><div class="sl-deco" data-icon="t"></div><h2>some text</h2><blockquote><p>bla bla</p><cite>Margi Clarke</cite></blockquote></div></div>');
    
    // call the plugin's add method
    ss.add($items);

    */
}
function initMap() {
    if ($(window).width()< 450) {

        var wit = $("#wit");
        var height = wit.outerWidth();
        wit.attr("height", height);
    }
    else
    {
        var wit = $("#wit");
        var zwart = $("#zwart");
        var height = zwart.outerHeight();
        wit.attr("height", height);
    }
    
}
function initProducts() {
   
    if ($(window).width() < 1000)
    {
        $('.special.cards .image').dimmer('show');
        $('.special.cards .image').on('click', function () {
            $('.special.cards .image').dimmer('hide');
        });
    }
    else
    {
        $('.special.cards .image').dimmer({
            on: 'hover'
        });
    }
    
}
function mobileErrormsg() {

    if ($(window).width() < 500)
    {
        var errormsg = $(".mbl");
        errormsg.removeClass("left");
        errormsg.removeClass("pointing");
        errormsg.addClass("pointing");
        errormsg.addClass("below");
    }

}
function initTabs()
{
    $('.tabular.menu .item').tab();
}
function initDataTables()
{
    if($("#myTable").length){
    $("#myTable").DataTable({
        "searching": false,
        "ordering": false,
        "lengthChange": false,
        "info":false,
        "pageLength": 3,
        "language":{
            "decimal":        "",
            "emptyTable":     "Geen gegevens beschikbaar",
            "info":           "Toont _START_ tot _END_ van de _TOTAL_ posts",
            "infoPostFix":    "",
            "thousands":      " ",
            "loadingRecords": "Laden...",
            "processing":     "Verwerken...",
            "search":         "Zoeken:",

            "paginate": {
                "first":      "Eerste",
                "last":       "Laatste",
                "next":       "Volgende",
                "previous":   "Vorige"
            },
    
        }
    });
    }

}

function initSliderImages() {
    img2 = $(".bg-img-2");
    img3 = $(".bg-img-3");
    img4 = $(".bg-img-4");
    img5 = $(".bg-img-5");
    img2.removeClass("bg-img-2");
    img3.removeClass("bg-img-3");
    img4.removeClass("bg-img-4");
    img5.removeClass("bg-img-5");
    img2.addClass("bg-img-2");
    img3.addClass("bg-img-3");
    img4.addClass("bg-img-4");
    img5.addClass("bg-img-5");
    
   
    if ($(window).width() < 500) {

        
        img2.removeClass("bg-img-2");
        img3.removeClass("bg-img-3");
        img4.removeClass("bg-img-4");
        img5.removeClass("bg-img-5");
        img2.addClass("bg-img-2Portable");
        img3.addClass("bg-img-3Portable");
        img4.addClass("bg-img-4Portable");
        img5.addClass("bg-img-5Portable");
    }


        
}

$(document).ready(function () {

    
    pageNavigation();
    initSlider();
    initTabs();
    initDataTables();


    $(window).bind("load", initSliderImages);
    $(window).bind("resize", initSliderImages);
    $(window).bind("orientationchange", initSliderImages);


    $(window).bind("load", initMap);
    $(window).bind("resize", initMap);
    $(window).bind("orientationchange", initMap);
    $(window).bind("load", initProducts);
    $(window).bind("resize", initProducts);
    $(window).bind("orientationchange", initProducts);
    $(window).bind("load", mobileErrormsg);
    $(window).bind("resize", mobileErrormsg);
    $(window).bind("orientationchange", mobileErrormsg);
    
   
});
$(window).load(function () {
    $("#loader").attr("style", "display:none;");
    var margintop = $(".navbar-fixed-top").outerHeight();
    console.log(margintop);

    var slider = $("#slider");
    console.log(slider.height());
    slider.css("margin-top", margintop);
    slider.css("height", slider.height() - margintop);





});

