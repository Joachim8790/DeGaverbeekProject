var previousID;
var activePage;
$(document).ready(function () {
    ActivePageSetClass();
    MaterializeInitialization();
    MegaDDLInit();

   

});

function MaterializeInitialization()
{
    $('select').material_select();
    $(".button-collapse").sideNav();
    $('#filterProducten').sideNav({
        menuWidth: 300, // Default is 300
        edge: 'right', // Choose the horizontal origin
        closeOnClick: true, // Closes side-nav on <a> clicks, useful for Angular/Meteor
        draggable: true, // Choose whether you can drag to open on touch screens,
    }   
  );
    $('.dropdown-button').dropdown();
    $('.modal').modal();
    $('.scrollspy').scrollSpy();
        
}
function MegaDDLInit() {
    if (activePage == "Products")
    {
        var megadropdown = $("#megaDropDown");
        previousID = $(".col.s12.active")[0].id;
        var indicator = $(".indicator");
        console.log("PreviousID: " + previousID);

        $(".tab").mouseenter(function () {
            var id = this.firstChild.href.split('#');
            HoverableTabs(id[1]);
            megadropdown.removeClass("hidden");
            indicator.addClass("indicatorpointer");
            indicator.attr("style", "margin-left:" + ($(this).width() / 2) + "px;");
        });

        $(".tab").mouseleave(function () {
            if ($('.categoryTabs:hover').length == 0) {// hovert niet over tabs
                if ($('.categoryTabsRow:hover').length == 0) {//hovert niet over tabs of megaddl
                    megadropdown.addClass("hidden");
                    indicator.removeClass("indicatorpointer");
                    indicator.attr("style", "margin-left:0;");
                    console.log("in tabs");
                }
                else {
                    console.log("In Megaddl");
                }
            }
            else {

            }
        });
        megadropdown.mouseenter(function () {


            megadropdown.removeClass("hidden");
            indicator.addClass("indicatorpointer");
            // indicator.attr("style", "margin-left:" + ($(this).width() / 2) + "px;");
        });
        megadropdown.mouseleave(function () {
            if ($('.categoryTabs:hover').length == 0) {// hovert niet over tabs
                megadropdown.addClass("hidden");
                HoverableTabs(previousID);
                indicator.removeClass("indicatorpointer");
                indicator.attr("style", "margin-left:0;");
            }
        });

    }
}
function HoverableTabs(id)
{
   
        $('ul.tabs').tabs('select_tab', id);

}
function ActivePageSetClass() {
    var uri = window.location.pathname;//get the uri of the current page
  
    var uriSubStrings = uri.split("/");//split into controller/action/data
    var action = uriSubStrings[2];//2nd is action
    activePage = action;// the global variable activePage is set here and can be used in different functions to check the action
    var activeItem = $(".icon-bar ." + action);//get the active item
    activeItem.addClass("active");
    var activeItemMobile = $("#mobile-demo ." + action)//get the active item for the mobile side navigation menu
    activeItemMobile.addClass("active");

}
