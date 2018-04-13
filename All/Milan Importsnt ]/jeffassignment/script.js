{
    alert("Welcome")
    }

function checkForm(form)
{
 
    if(form.Pswrd.value == form.Cpswrd.value)
        {
        alert("Username and password has been set")/*opens the target page while Id & password matches*/
        }
        else
        {
        alert("Error Password or Username")/*displays error message*/
        
        }
        function check(form)/*function to check userid & password*/
        {
        if (form.Username.value.length < minlength)
        {
        alert('Your Username must be at least ' + minlength + ' characters long. Try again.');
        }
        else {
        alert("return false")
        }
    }return false;
  }

}