create procedure eliminarProducto
	@prodId integer
as
	delete from product where productId = @prodId