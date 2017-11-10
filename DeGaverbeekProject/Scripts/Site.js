$(document).ready(function () {
    $('.slider').slider();
    circularmenu();
    $(window).bind("load", resizeShopRight);
    $(window).bind("resize", resizeShopRight);
    $(window).bind("orientationchange", resizeShopRight);
    $(window).bind("load", resizeWelcomeRight);
    $(window).bind("resize", resizeWelcomeRight);
    $(window).bind("orientationchange", resizeWelcomeRight);

});


function circularmenu()
{
    var nbOptions = 8;
    var angleStart = -360;

    // jquery rotate animation
    function rotate(li,d) {
        $({d:angleStart}).animate({d:d}, {
            step: function(now) {
                $(li)
                   .css({ transform: 'rotate('+now+'deg)' })
                   .find('label')
                      .css({ transform: 'rotate('+(-now)+'deg)' });
            }, duration: 0
        });
    }

    // show / hide the options
    function toggleOptions(s) {
        $(s).toggleClass('open');
        var li = $(s).find('li');
        var deg = $(s).hasClass('half') ? 180/(li.length-1) : 360/li.length;
        for(var i=0; i<li.length; i++) {
            var d = $(s).hasClass('half') ? (i*deg)-90 : i*deg;
            $(s).hasClass('open') ? rotate(li[i],d) : rotate(li[i],angleStart);
        }
    }

    $('.selector button').click(function(e) {
        toggleOptions($(this).parent());
    });

    setTimeout(function() { toggleOptions('.selector'); }, 100);//@ sourceURL=pen.js


}
function resizeWelcomeRight(){

    var welcomeleft = $(".welcome_left");
    var welcomeright = $(".welcome_right");

    var height = welcomeleft.innerHeight();
    welcomeright.attr("style","height:"+height+"px;")

}
function resizeShopRight(){
    var shopleft = $("#shopleft");
    var shopright = $("#shopright");
    if ($(window).width() < 1000) {

    }
    else
    {
        
        var height = shopleft.innerHeight();
        $("#shopright").attr("style", "height:" + height + "px;width:" + height + "px;");
    }
    var shoprightheight = shopright.innerHeight();
    var shopleftwidth = shopleft.innerWidth(); 
    var centerlogo = $(".center-logo");
    var height = centerlogo.innerHeight();
    var width = centerlogo.innerWidth();
    centerlogo.attr("style", "margin-top:" + ((shoprightheight / 2) - (height / 2)) + "px;");
    
   
}