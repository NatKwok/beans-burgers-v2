var mainStuff = document.getElementById("mainStuff");

var heights = window.innerHeight;
var middle = window.innerHeight / 4;
document.getElementById("mainStuff").style.paddingTop = middle + "px";

function resize()
{
    document.getElementById("mainStuff").style.height = heights -1 + "px";
}

resize();
window.onresize = function() {
    resize();
};

window.onscroll = function(){
    resize();
};


