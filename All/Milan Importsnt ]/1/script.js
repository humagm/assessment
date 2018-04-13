    {
    alert("Welcome")
    }
   
    
    function check(form)/*function to check userid & password*/
    {
    if(form.psw.value == form.Cpsw.value)
    {
    alert("Username and password has been set")/*opens the target page while Id & password matches*/
    }
    else
    {
    alert("Error Password or Username")/*displays error message*/
    
    }
    function check(form)/*function to check userid & password*/
    {
    if (form.Un.value.length < minlength)
    {
    alert('Your Username must be at least ' + minlength + ' characters long. Try again.');
    }
    else {
    alert("return false")
    }
    }
    }