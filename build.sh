dotnet build ./src -o ./bin/debug
cargo build --manifest-path ./lib/Cargo.toml
cp ./lib/target/debug/lib.dll ./bin/debug/lib.dll

# run
# ./bin/debug/src.exe