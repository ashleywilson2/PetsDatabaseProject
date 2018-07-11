// JavaScript source code
function database(){
  $('#addPet').click(function(){
    var petName = $('#petName').val();
    var petAge = $('#petAge').val();
    //How do you do isSpotted?
    var isSpotted = ;
    var petColor = $('#petColor').val();
    var data = { petName, petAge, isSpotted, petColor };
    var dataString = JSON.stringify(data);
    $.ajax({
        url: "http://localhost:55053/api/pets",
        contentType: "application/json",
        data : dataString,
        type: "POST"
      });
    });

  $('#showAllPets').click(function(){
    $.get( "http://localhost:55053/api/pets", function(data){
      $('.petInfo').append(data);
    });
  });
}
