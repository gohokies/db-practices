find_package(ODBC)

add_executable(mssql_odbc_sample sample.cpp)

target_link_libraries(mssql_odbc_sample ODBC::ODBC)