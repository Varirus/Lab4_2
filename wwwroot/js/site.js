function initMap() {
    var mapOptions = {
        center: { lat: 51.1079, lng: 17.0385 }, //Lokacja Wroclaw
        zoom: 12
    };

    var map = new google.maps.Map(document.getElementById("map"), mapOptions);
}