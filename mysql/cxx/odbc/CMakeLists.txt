find_package(ODBC)
add_executable(mysql_odbc_sample sample.cpp)

target_link_libraries(mysql_odbc_sample ODBC::ODBC)