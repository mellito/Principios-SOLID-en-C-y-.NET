# Single responsibility principle

- distribuye las responsabilidades en diferentes componentes dentro de un sistema, donde cada componente tiene una unica responsabilidad
- aplica para modulos, clases, metodos y funciones

- ejemplo: como usuario luego de confirmar la compra espero ver un mensaje de confirmacion, tener la posibilidad de descargar la factura y un correo electronico de confirmacion
  responsabilidades unicas
- mensaje de confirmacion
- descargar la factura
- correo electronico de confirmacion

- Demo - escenario
  tenemos una clase student repository encargada de administrar los daos para el modelo student, pero en este momento no cumple con el principio de responsabilidad unica, debe solucionarse
