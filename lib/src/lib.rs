#[no_mangle]
pub extern "C" fn call_rust_fn() -> u32 {
    8000
}

#[cfg(test)]
mod tests {
    #[test]
    fn it_works() {
        let result = 2 + 2;
        assert_eq!(result, 4);
    }
}
