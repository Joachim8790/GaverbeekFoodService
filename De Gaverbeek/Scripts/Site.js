
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
        "pageLength": 3
    });
    }

}
function renderPost() {
    if ($("#txtTitel").length) {
        var txtTitel = $("#txtTitel");
        var txtBeschrijving = $("#txtBeschrijving");
        var txtAfbeelding = $("#txtAfbeelding");
        var divTitel = $("#divTitel");
        var divBeschrijving = $("#divBeschrijving");
        var divAfbeelding = $("#divAfbeelding");

        console.log("started")



        txtTitel.change(function () {
            divTitel.html(txtTitel.val());
        });
        txtBeschrijving.change(function () {
            divBeschrijving.html(txtBeschrijving.val());
        });
        var fileInput = document.getElementById('txtAfbeelding');
        var fileDisplayArea = document.getElementById('divAfbeelding');


        fileInput.addEventListener('change', function (e) {
            var file = fileInput.files[0];
            var imageType = /image.*/;

            if (file.type.match(imageType)) {
                var reader = new FileReader();

                reader.onload = function (e) {
                    fileDisplayArea.innerHTML = "";

                    var img = new Image();
                    img.className = "ui postimage";
                    img.width = 150;
                    img.height = 150;
                    img.src = reader.result;

                    fileDisplayArea.appendChild(img);
                }

                reader.readAsDataURL(file);
            } else {
                fileDisplayArea.innerHTML = "File not supported!"
            }
        });
    }
    else
    {

    }


}
$(document).ready(function () {

    
    pageNavigation();
    initSlider();
    initTabs();
    initDataTables();
    renderPost();

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

});

