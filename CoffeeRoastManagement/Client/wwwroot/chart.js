window.setup = (id, config) => {
    console.log("TEST")
    var ctx = document.getElementById(id).getContext('2d');
    new Chart(ctx, config);
}

window.artisanprofilegraph = (id, config) => {
    var ctx = document.getElementById(id).getContext('2d');
    new Chart(ctx, config);
}