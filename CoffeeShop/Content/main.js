 var pass = '';

function adminAuth() {
	pass = prompt('Введить пароль','');
		if( pass == 'qwerty'){
			window.location.href = "http://localhost:11507/Home/Admin";
			
		}else{
			alert('Неправльный пароль')
		}
		
}