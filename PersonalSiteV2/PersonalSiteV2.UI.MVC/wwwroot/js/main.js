function setColor(color) {
	let currentColor = document.getElementById('color-changer')
	//let currentFav = document.getElementById('Favicon')
	switch (color) {
		case 'blue':
			let currentPath = currentColor.getAttribute('href');
			console.log(currentPath);
			currentColor.setAttribute('href', '../css/colors/blue.css')
			
			break;
		case 'green':
			currentColor.setAttribute('href', '../css/colors/green.css')
			
			break;
		case 'yellow':
			currentColor.setAttribute('href', '../css/colors/yellow.css')
			
			break;
		case 'red':
			currentColor.setAttribute('href', '../css/colors/red.css')
			
			break;
	}
	localStorage.setItem('jsColor', color)
	
}
if (localStorage.getItem('jsColor') != null) {
	setColor(localStorage.getItem('jsColor'))
}
