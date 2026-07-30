## Principio de Inversión de Dependencia en Programación SOLID

- busca desacoplar los componentes de la aplicacion
- nos ayuda a realizar cambios afectando el codigo lo menos posible
- se debe implementar con tipos abstractos
- existen 3 tipos inyeccion de dependencia por constructor, por propiedad o por parametro
- dependencia por constructor es el mas comun
- la inyeccion de dependencias es fundamental para poder aplicar la metodologia test driven development (TDD)

- singleton: misma referencia en todo el ciclo de vida de la api
- scope: cada componente que lo use solo una vez
- transient: se crea una referencia en todo los componentes que la use
