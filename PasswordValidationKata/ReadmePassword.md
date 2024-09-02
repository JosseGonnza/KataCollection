<img width="100%" src="https://capsule-render.vercel.app/api?type=waving&color=9df2ea&animation=fadeIn&height=120&section=header"/>

## Introducción:

Imagina que estás creando una nueva cuenta en tu sitio web favorito. Todo va bien hasta que llegas al campo de "contraseña". Sabes que no puedes usar "123456" o "password" porque el sitio tiene requisitos estrictos de seguridad, y justo en ese momento, te das cuenta de que necesitas recordar todas esas reglas complicadas que hacen que tu contraseña sea "segura".

Los sitios web modernos son muy exigentes cuando se trata de contraseñas. No basta con tener solo letras o números; tiene que haber una mezcla cuidadosamente balanceada de caracteres. Tu tarea es crear una función que valide si una contraseña es lo suficientemente fuerte según estas reglas de seguridad.

Este ejercicio te permitirá reforzar tus habilidades de programación al crear un validador de contraseñas. ¡Es hora de programar y asegurarnos de que las contraseñas sean seguras y difíciles de descifrar!

## Tener en cuenta:

- Escribir un test de fallo para un caso básico de validación de contraseña.
- Implementar la menor cantidad de código necesaria para que el test pase.
- A medida que añadas más tests, refactoriza el código para hacerlo más genérico y robusto.

## Instrucciones:

Escribe una función que valide si una contraseña cumple con los siguientes criterios:

- Debe contener al menos una letra mayúscula.
- Debe contener al menos una letra minúscula.
- Debe contener al menos un número.
- Debe tener al menos 8 caracteres de longitud.

Por ejemplo, dado el siguiente conjunto de contraseñas, la función debería devolver:

```plaintext
password("Abcd1234"); ===> true
password("Abcd123"); ===> false
password("abcd1234"); ===> false
password("AbcdefGhijKlmnopQRsTuvwxyZ1234567890"); ===> true
password("ABCD1234"); ===> false
password("Ab1!@#$%^&*()-_+={}[]|\:;?/>.<,"); ===> true;
password("!@#$%^&*()-_+={}[]|\:;?/>.<,"); ===> false;
```

<img src="https://raw.githubusercontent.com/matfantinel/matfantinel/master/waves.svg" width="100%" height="100">